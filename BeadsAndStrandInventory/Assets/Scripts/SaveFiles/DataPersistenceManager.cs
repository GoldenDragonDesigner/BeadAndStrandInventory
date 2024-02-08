using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File Storage Configuration")]
    [SerializeField]
    private string fileName;

    private DataForBeads dataForBeads;
    private List<IDataPersistence> dataPersistenceObjects;
    //private List<IDataPersistence> dataPersistenceObjectsScriptable;
    private FileDataHandler dataHandler;

    public static DataPersistenceManager instance { get; private set; }

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("Found more than one Data Persistance Manager in the scene");
        }
        instance = this;
    }

    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        this.dataPersistenceObjects = FindAllDataPersistenceObjects();
        //this.dataPersistenceObjectsScriptable = FindAllDataPersistenceObjectsScriptable();
        LoadBead();
    }

    //same as NewGame
    public void NewBead()
    {
        this.dataForBeads = new DataForBeads();
    }

    //same as loadGAme
    public void LoadBead()
    {
        //TODO - Load any saved data from a file using the data handler
        this.dataForBeads = dataHandler.Load();
        // if no data can be loaded, initialize a new game
        if(this.dataForBeads == null)
        {
            Debug.Log("No Data was found. Initializing data to defaults.");
            NewBead();
        }

        // TODO - push the Loaded data to all other script that need
        foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.LoadData(dataForBeads);
        }

        //foreach(IDataPersistence dataPersistenceObjScript in dataPersistenceObjectsScriptable)
        //{
        //    dataPersistenceObjScript.LoadData(dataForBeads);
        //}

        Debug.Log("Loaded bead amount = " + dataForBeads.garnetBeadSize);
    }

    //same as saveGame
    public void SaveBead()
    {
        //TODO - pass the data to other scripts so they can update it
        foreach(IDataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.SaveData(ref dataForBeads);
        }

        //foreach(IDataPersistence dataPersistenceObjScript in dataPersistenceObjectsScriptable)
        //{
        //    dataPersistenceObjScript.SaveData(ref dataForBeads);
        //}

        Debug.Log("Save Bead Amount = " + dataForBeads.garnetBeadSize);

        //TODO - save that data to a file using the data handler
        dataHandler.Save(dataForBeads);
    }

    //this is where the saving actually can happen
    private void OnApplicationQuit()
    {
        //SaveBead();
    }

    public void SaveButtonPress()
    {
        SaveBead();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistenceObjects);
    }

    //private List<IDataPersistence> FindAllDataPersistenceObjectsScriptable()
    //{
    //    IEnumerable<IDataPersistence> dataPersistenceObjectsScriptable = FindObjectsOfType<ScriptableObject>().OfType<IDataPersistence>();

    //    return new List<IDataPersistence>(dataPersistenceObjectsScriptable);
    //}
}