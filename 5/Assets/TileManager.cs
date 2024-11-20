using UnityEngine;

public class TileManager : MonoBehaviour
{
    public int rows = 50; // تعداد ردیف‌ها
    public int cols = 50; // تعداد ستون‌ها
    public GameObject prefabClickableTile; // مرجع به Prefab کاشی

    void Start()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                float y = 0.01f; // ارتفاع کاشی
                Vector3 pos = new Vector3(r - rows / 2, y, c - cols / 2); // محاسبه موقعیت کاشی
                Instantiate(prefabClickableTile, pos, Quaternion.identity); // ساخت کاشی
            }
        }
    }
}
