using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
        
        public GameObject carPrefab;        
        public GameObject coinPrefab;       
        public GameObject conePrefab;        
        private int startPos = 80;
        private GameObject unitychan;
        
        private int goalPos = 360;
        //private int initDraw = 45;
        private bool generateItems = true;
        private int nextSegment = 80;
        private int segmentLength = 15;
        
        private float posRange = 3.4f;

        // Start is called before the first frame update
        void Start ()
        {
            this.unitychan = GameObject.Find("unitychan");
                
            GenerateItem(this.startPos);
            

          
        }

        // Update is called once per frame
        void Update ()
        {
            int i = (int)this.unitychan.transform.position.z;
            
            if((i+this.startPos+15==this.nextSegment)&&(this.nextSegment<this.goalPos)){                
                
                    Debug.Log("item gen");
                    GenerateItem(this.nextSegment);                  
                    this.generateItems = false;
                                        
                               
            }

            // while(generateItems = true){

            // }
        }

        void GenerateItem(int i){
            int num = Random.Range (1, 11);
                if (num <= 2)
                {                                
                    for (float j = -1; j <= 1; j += 0.4f)
                    {
                            GameObject cone = Instantiate (conePrefab);
                            cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);
                    }
                }
                else
                {                    
                    for (int j = -1; j <= 1; j++)
                    {
                        
                        int item = Random.Range (1, 11);                        
                        int offsetZ = Random.Range(-5, 6); 
                        
                        if (1 <= item && item <= 6)
                        {
                                
                            GameObject coin = Instantiate (coinPrefab);
                            coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                        }
                        else if (7 <= item && item <= 9)
                        {
                                
                            GameObject car = Instantiate (carPrefab);
                            car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                        }
                    }
                }                
            this.nextSegment += 15;
            Debug.Log("next segment:" + this.nextSegment);
            this.generateItems = true;
        }


}