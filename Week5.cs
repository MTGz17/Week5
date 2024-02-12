using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week5 : MonoBehaviour
{
    public string name;
    public int level;
    enum dataType {Artificer , Barbarian , Bard , Cleric , Druid , Fighter , Monk , Ranger , Rogue , Paladin , Sorcerer , Wizard , Warlock};
    [SerializeField] dataType classType;
    int classTypeNum;
    public int Constitution;
    public bool hillDwarf;
    public bool toughFeat;
    public bool rolled;
    int Con;
    int hillDwarfNum;
    int toughFeatNum;
    int totalRolled;
    int rolledNum;
    int total;

    void Start()
    {
        classTypeNum = System.Convert.ToInt32(classType);
        hillDwarfNum = System.Convert.ToInt32(hillDwarf);
        toughFeatNum = System.Convert.ToInt32(toughFeat);

        Con = ((Constitution/2)-5);
        if (Con <= 0){
            Con = 0;
        }
        if (Con >= 10){
            Con = 10;
        }

        //2D Array
        int [,] ConstitutionArray = new int [11,2];
        
        int [,] ConstitutionArrayInit = {
            {0,0},
            {1,1},
            {2,2},
            {3,3},
            {4,4},
            {5,5},
            {6,6},
            {7,7},
            {8,8},
            {9,9},
            {10,10}
        };

        Dictionary<int, int> isHillDwarf = new Dictionary<int, int>();
        isHillDwarf.Add(0,0);
        isHillDwarf.Add(1,1);

        Dictionary<int, int> hasToughFeat = new Dictionary<int, int>();
        hasToughFeat.Add(0,0);
        hasToughFeat.Add(1,2);

        if (rolled){
        Dictionary<int, int> classTypeDic = new Dictionary<int, int>();
        classTypeDic.Add(0, Random.Range(1,9));
        classTypeDic.Add(1, Random.Range(1,13));
        classTypeDic.Add(2, Random.Range(1,9));
        classTypeDic.Add(3, Random.Range(1,9));
        classTypeDic.Add(4, Random.Range(1,9));
        classTypeDic.Add(5, Random.Range(1,11));
        classTypeDic.Add(6, Random.Range(1,9));
        classTypeDic.Add(7, Random.Range(1,11));
        classTypeDic.Add(8, Random.Range(1,9));
        classTypeDic.Add(9, Random.Range(1,11));
        classTypeDic.Add(10, Random.Range(1,7));
        classTypeDic.Add(11, Random.Range(1,7));
        classTypeDic.Add(12, Random.Range(1,9));

        for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = classTypeDic[classTypeNum];
                        totalRolled = totalRolled + rolledNum;
                    }

            total = ((totalRolled)+(level*ConstitutionArrayInit[Con,1])+(level*isHillDwarf[hillDwarfNum])+(level*(hasToughFeat[toughFeatNum])));
            Debug.Log(name+ "\nThe " +classType+ " has " +total+ " health at level " +level);
        }

        if (!rolled){
        Dictionary<int, int> classTypeDic = new Dictionary<int, int>();
        classTypeDic.Add(0, 4);
        classTypeDic.Add(1, 6);
        classTypeDic.Add(2, 4);
        classTypeDic.Add(3, 4);
        classTypeDic.Add(4, 4);
        classTypeDic.Add(5, 5);
        classTypeDic.Add(6, 4);
        classTypeDic.Add(7, 5);
        classTypeDic.Add(8, 4);
        classTypeDic.Add(9, 5);
        classTypeDic.Add(10, 3);
        classTypeDic.Add(11, 3);
        classTypeDic.Add(12, 4);

        total = (int)(((classTypeDic[classTypeNum]+.5)*level)+(level*ConstitutionArrayInit[Con,1])+(level*isHillDwarf[hillDwarfNum])+(level*(hasToughFeat[toughFeatNum])));
        Debug.Log(name+ "\nThe " +classType+ " has " +total+ " health at level " +level);
        }
    }
}