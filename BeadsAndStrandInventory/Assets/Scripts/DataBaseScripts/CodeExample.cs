using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BansheeGz.BGDatabase;
using System;

public class CodeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //number of tables
        int numberOfTables = BGRepo.I.CountMeta;


        //print table names
        BGRepo.I.ForEachMeta(meta => print(meta.Name));


        //create new table
        BGMetaEntity newTable = new BGMetaRow(BGRepo.I, "NewTable");


        //create new field
        BGField newField = new BGFieldInt(newTable, "NewField");


        //number of columns (fields) for table "Table"
        int numberOfFields = BGRepo.I["NewTable"].CountFields;


        //print field names for table "NewTable"
        BGRepo.I["NewTable"].ForEachField(field => print(field.Name));


        //type of field "Field" from Table "NewTable" (Int32)
        Type fieldType = BGRepo.I["NewTable"].GetField("NewField").ValueType;


        //get reference to table NewTable
        BGMetaEntity table = BGRepo.I["NewTable"];

        //create new row
        BGEntity row = table.NewEntity();

        //get a row by index (row.Index=0)
        BGEntity firstRow = table.GetEntity(row.Index);

        //get a row by ID (alternative)
        firstRow = table.GetEntity(row.Id);

        //read "NewField" field value (first row)
        int firstRowNewFieldValue = firstRow.Get<int>("NewField");

        //write "NewField" field value (first row)
        firstRow.Set<int>("NewField", 7);


        //populate new table with 10 records
        for (var i = 0; i < 10; i++) newTable.NewEntity().Name = "Entity #" + i;


        //number of rows for table "NewTable"
        int numberOfRows = BGRepo.I["NewTable"].CountEntities;


        //find entities, which names contains '5'
        List<BGEntity> entities = newTable.FindEntities(
                entity => !string.IsNullOrEmpty(entity.Name) && entity.Name.IndexOf('5') != -1);


        //find entities, which names contains '5' and sort them by NewField
        List<BGEntity> entities2 = newTable.FindEntities(
                entity => !string.IsNullOrEmpty(entity.Name) && entity.Name.IndexOf('5') != -1, null,
                (e1, e2) => e1.Get<int>("NewField").CompareTo(e2.Get<int>("NewField")));

        //the same as above, (faster version)
        BGField<int> fieldWithType = (BGField<int>)BGRepo.I["NewTable"].GetField("NewField");
        List<BGEntity> entities3 = newTable.FindEntities(
                entity => !string.IsNullOrEmpty(entity.Name) && entity.Name.IndexOf('5') != -1, null,
                (e1, e2) => fieldWithType[e1.Index].CompareTo(fieldWithType[e2.Index]));

        //the same as above with code generation, (faster and better version)
        //List<NewTable> entities4 = NewTable.FindEntities(
        //        entity => !string.IsNullOrEmpty(entity.Name) && entity.Name.IndexOf('5') != -1, null,
        //       (e1, e2) => e1.NewField.CompareTo(e2.NewField));


        //print all entities names
        newTable.ForEachEntity(entity => print(entity.Name));


        //print all entities names, which contains "5"
        newTable.ForEachEntity(entity => print(entity.Name),
                entity => !string.IsNullOrEmpty(entity.Name) && entity.Name.IndexOf('5') != -1);


        // query new table and increase NewField by 1, for each NewField value which is lesser than 5,
        // iteration is sorted by NewField
        newTable.ForEachEntity(entity =>
        {
            entity.Set("NewField", entity.Get<int>("NewField") + 1);
        }, entity => entity.Get<int>("NewField") < 5,
           (e1, e2) => e1.Get<int>("NewField").CompareTo(e2.Get<int>("NewField")));

        //the same as above (faster version)
        BGField<int> fieldWithType2 = (BGField<int>)BGRepo.I["NewTable"].GetField("NewField");
        newTable.ForEachEntity(entity =>
        {
            var val = fieldWithType2[entity.Index] + 1;
            fieldWithType2[entity.Index] = val;
        }, entity => fieldWithType2[entity.Index] < 5,
           (e1, e2) => fieldWithType2[e1.Index].CompareTo(fieldWithType2[e2.Index]));

        //the same as above (version with code generation, faster and better)
        // NewTable.ForEachEntity(entity => entity.NewField++, entity => entity.NewField < 5,
        //    (e1, e2) => e1.NewField.CompareTo(e2.NewField));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
