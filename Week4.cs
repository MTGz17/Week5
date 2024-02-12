using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4 : MonoBehaviour
{
    public string name;
    public int level;
    enum dataType {Artificer , Barbarian , Bard , Cleric , Druid , Fighter , Monk , Ranger , Rogue , Paladin , Sorcerer , Wizard , Warlock}
    [SerializeField] dataType classType;
    public int CON;
    public bool hillDwarf;
    public bool toughFeat;
    public bool rolled;
    int hillDwarfNum;
    int toughFeatNum;
    int Con;
    int rolledNum;
    int totalRolled;
    int total;

    // Start is called before the first frame update
    void Start()
    {   
        hillDwarfNum = System.Convert.ToInt32(hillDwarf);
        toughFeatNum = System.Convert.ToInt32(toughFeat);
        Con = ((CON/2)-5);
        if (Con <= 0){
            Con = 0;
        }
        if (Con >= 10){
            Con = 10;
        }

        switch (classType)   {
            case dataType.Artificer:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,9);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Artificer has " +total+ " health at level " +level);
                }

            if (!rolled)
                {
                    total = (int)((4.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Artificer has " +total+ " health at level " +level);
                }
                
            break;
            case dataType.Barbarian:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,13);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Barbarian has " +total+ " health at level " +level);
                }
           if (!rolled)
                {
                    total = (int)((6.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Barbarian has " +total+ " health at level " +level); 
                }
            break;
            case dataType.Bard:
             if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,9);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Bard has " +total+ " health at level " +level);
                }
            if (!rolled)
                {
                    total = (int)((4.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Bard has " +total+ " health at level " +level);
                }

            break;
            case dataType.Cleric:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,9);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Cleric has " +total+ " health at level " +level);
                }
                if (!rolled)
                {
                    total = (int)((4.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Cleric has " +total+ " health at level " +level);
                }

            break;
            case dataType.Druid:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,9);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Druid has " +total+ " health at level " +level);  
                }
                if (!rolled)
                {
                    total = (int)((4.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Druid has " +total+ " health at level " +level); 
                } 

            break;
            case dataType.Fighter:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,11);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Fighter has " +total+ " health at level " +level);  
                }
                if (!rolled)
                {
                    total = (int)((5.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Fighter has " +total+ " health at level " +level);  
                }

            break;
            case dataType.Monk:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,9);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Monk has " +total+ " health at level " +level);  
                }
                if (!rolled)
                {
                    total = (int)((4.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Monk has " +total+ " health at level " +level);
                }  

            break;
            case dataType.Ranger:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,11);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Ranger has " +total+ " health at level " +level); 
                }
                if (!rolled)
                {
                    total = (int)((5.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Ranger has " +total+ " health at level " +level);  
                }

            break;
            case dataType.Rogue:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,9);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Rogue has " +total+ " health at level " +level);  
                }
                if (!rolled)
                {
                    total = (int)((4.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Rogue has " +total+ " health at level " +level);  
                }

            break;
            case dataType.Paladin:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,11);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Paladin has " +total+ " health at level " +level);
                }
                if (!rolled)
                {
                    total = (int)((5.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Paladin has " +total+ " health at level " +level);  
                }

            break;
            case dataType.Sorcerer:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,7);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Sorcerer has " +total+ " health at level " +level); 
                }
                if (!rolled)
                {
                    total = (int)((3.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Sorcerer has " +total+ " health at level " +level);
                }  

            break;
            case dataType.Wizard:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,7);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Wizard has " +total+ " health at level " +level); 
                }
                if (!rolled)
                {
                    total = (int)((3.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Wizard has " +total+ " health at level " +level);  
                }

            break;
            case dataType.Warlock:
            if (rolled)
                {
                    for (int i = 1; i < (level + 1); i++)
                    {
                        rolledNum = Random.Range(1,9);
                        totalRolled = totalRolled + rolledNum;
                    }
                    total = ((totalRolled)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Warlock has " +total+ " health at level " +level);  
                }
                if (!rolled)
                {
                    total = (int)((4.5*level)+(level*Con)+(level*hillDwarfNum)+(level*(toughFeatNum*2)));
                    Debug.Log(name+ "\nThe Warlock has " +total+ " health at level " +level);  
                }
            break;
        } 
        
    }

}