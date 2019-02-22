using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Terrain terrain;
    public int maxNam;
    public GameObject[] sword;
    public float radius;

    public void InstantiateEnemy()
    {
        GameObject parentObj = new GameObject("Enemys");

        for (int i = 0; i < maxNam; i++)
        {
            bool check = false;
            RaycastHit hit;

            float randX;
            float randZ;

            int count = 0;

            while(!check && count < 3)
            {
                randX = Random.Range(terrain.GetPosition().x, terrain.GetPosition().x + terrain.terrainData.size.x);
                randZ = Random.Range(terrain.GetPosition().z, terrain.GetPosition().z + terrain.terrainData.size.z);

                //　Terrainと接触した位置を探す
                if (Physics.Raycast(new Vector3(randX, terrain.GetPosition().y + terrain.terrainData.size.y, randZ), Vector3.down, out hit, terrain.GetPosition().y + terrain.terrainData.size.y + 100f, LayerMask.GetMask("Field")))
                {
                    //　Player、swordという名前のレイヤーと接触してなければ地面の接触ポイントに敵を配置
                    if (!Physics.SphereCast(new Vector3(randX, terrain.GetPosition().y + terrain.terrainData.size.y, randZ), radius, Vector3.down, out hit, terrain.GetPosition().y + terrain.terrainData.size.y + 100f, LayerMask.GetMask("Player", "sword")))
                    {
                        GameObject tempObj = Instantiate(sword[Random.Range(0, sword.Length)], hit.point, Quaternion.identity) as GameObject;
                        tempObj.transform.SetParent(parentObj.transform);
                        check = true;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
        }
        //　どれだけの敵が配置されたか確認
        Debug.Log(parentObj.transform.childCount);
    }


 

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
 
}
}