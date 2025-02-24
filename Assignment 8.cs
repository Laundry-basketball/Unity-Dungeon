using UnityEngine;

public class DungeonRoom : MonoBehaviour
{
    public GameObject[] Doors { get; set; }

    void Start()
    {
        UpdateDoors();
    }

    void Update()
    {
        if (Core.Instance != null)
        {
            UpdateDoors();
        }
    }

    void UpdateDoors()
    {
        for (int i = 0; i < Doors.Length; i++)
        {
            Doors[i].SetActive(Core.Instance.AreDoorsVisible);
        }
    }
}

public class Core : MonoBehaviour
{
    public static Core Instance;
    public bool AreDoorsVisible = true;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

