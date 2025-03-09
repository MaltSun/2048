using System.Collections.Generic;
using UnityEngine;



public class TileBoard : MonoBehaviour
{
public Tile tilePrefab;
public TileState[] tileStates;

   private TileGrid grid;
    private List<Tile> tiles;

 private void Awake()
    {
        grid = GetComponentInChildren<TileGrid>();
        tiles = new List<Tile>(16);
    }

    private void State(){
CreateTile();
CreateTile();
    }

    private void CreateTile(){
Tile tile = Instantiate(tilePrefab, grid.transform);

    }
}
