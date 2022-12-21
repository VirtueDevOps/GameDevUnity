using UnityEngine;

public class Town : MonoBehaviour
{
    // The name of the town
    public string townName;

    // The number of buildings in the town
    public int numBuildings;

    // An array of buildings in the town
    public Building[] buildings;

    // A list of NPCs that live in the town
    public List<NPC> npcs;

    void Start()
    {
        // Initialize the town and its buildings
        InitializeTown();
    }

    void Update()
    {
        // Update the town and its buildings
        UpdateTown();
    }

    void InitializeTown()
    {
        // Set the name of the town
        townName = "My Town";

        // Initialize the buildings in the town
        buildings = new Building[numBuildings];
        for (int i = 0; i < numBuildings; i++)
        {
            buildings[i] = new Building();
        }

        // Initialize the NPCs in the town
        npcs = new List<NPC>();
        npcs.Add(new NPC("Bob", "Blacksmith"));
        npcs.Add(new NPC("Sue", "Shopkeeper"));
        npcs.Add(new NPC("Joe", "Innkeeper"));
    }

    void UpdateTown()
    {
        // Update the buildings in the town
        foreach (Building building in buildings)
        {
            building.Update();
        }

        // Update the NPCs in the town
        foreach (NPC npc in npcs)
        {
            npc.Update();
        }
    }
}
