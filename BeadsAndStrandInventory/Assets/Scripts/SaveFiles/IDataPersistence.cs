using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataPersistence
{
    void LoadData(DataForBeads bead);

    void SaveData(ref DataForBeads bead);
}
