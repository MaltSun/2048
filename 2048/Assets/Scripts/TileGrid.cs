
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    public TileRow[] rows { get; private set; }
    public TileCell[] cells { get; private set; }

 public int Size => cells.Length;
    public int Height => rows.Length;
    public int Width => Size / Height;

     private void Awake()
    {
        rows = GetComponentsInChildren<TileRow>();
        cells = GetComponentsInChildren<TileCell>();

        // for (int i = 0; i < cells.Length; i++) {
        //     cells[i].coordinates = new Vector2Int(i % Width, i / Width);
        // }
    }

    private void Start(){
        for(int y =0; y < rows.Length; y++){
            for(int x =0; x < rows[y].cells.Length; x++){
                rows[y].cells[x].coordinates = new Vector2Int(x, y);
            }
        }
    }
}
