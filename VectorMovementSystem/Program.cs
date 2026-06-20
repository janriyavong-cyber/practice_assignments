using System;

// 📐 สร้างโครงสร้าง Vector3 จำลองขึ้นมาเองเพื่อให้รันนอก Unity ได้
public struct CustomVector3
{
    public float x;
    public float y;
    public float z;

    // คอนสตรัคเตอร์สำหรับกำหนดค่า X, Y, Z
    public CustomVector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // ลอจิกสำหรับการเอาเวกเตอร์มาบวกกัน ( moveRight + moveForward )
    public static CustomVector3 operator +(CustomVector3 a, CustomVector3 b)
    {
        return new CustomVector3(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    // ลอจิกสำหรับการเอาเวกเตอร์มาลบกัน ( bossPosition - playerPosition )
    public static CustomVector3 operator -(CustomVector3 a, CustomVector3 b)
    {
        return new CustomVector3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    // สูตรพีทาโกรัสหาความยาวลูกศร (ทฤษฎีระยะห่างสามมิติ)
    public float magnitude
    {
        get { return (float)Math.Sqrt((x * x) + (y * y) + (z * z)); }
    }

    // สั่งจัดรูปแบบการแสดงผลตอนเขียนใน Console
    public override string ToString()
    {
        return $"({x}, {y}, {z})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== [เริ่มทำการทดสอบระบบคำนวณเวกเตอร์ 3D] ===");
        Console.WriteLine();

        // ========================================================
        // 1. วิธีประกาศสร้างลูกศร Vector3 (X, Y, Z)
        // ========================================================
        CustomVector3 moveRight = new CustomVector3(3f, 0f, 0f);    // ขวา 3 หน่วย
        CustomVector3 moveForward = new CustomVector3(0f, 0f, 4f);  // หน้า 4 หน่วย

        // ========================================================
        // 2. การเอา Vector มาบวกกัน (ใช้หาทิศทางการเดินเฉียง)
        // ========================================================
        CustomVector3 combinedMove = moveRight + moveForward;
        
        Console.WriteLine($"[Vector บวกกัน] ทิศทางเดินเฉียงรวม: {combinedMove}");

        // ========================================================
        // 3. การหา \"ระยะห่าง\" ระหว่างวัตถุสองชิ้น (Distance)
        // ========================================================
        CustomVector3 playerPosition = new CustomVector3(0f, 0f, 0f);  // พิกัดเจ้ายาแดง
        CustomVector3 bossPosition = new CustomVector3(6f, 0f, 8f);    // พิกัดบอสขุมนรก

        // เอาตำแหน่งเป้าหมาย - ตำแหน่งตั้งต้น เพื่อหาลูกศรชี้ไปหาบอส
        CustomVector3 directionToBoss = bossPosition - playerPosition; 
        
        // ถอดสแควรูทหาความยาวเมตรดิบ ๆ ด้วยลอจิกเบื้องหลัง .magnitude
        float distanceToBoss = directionToBoss.magnitude;

        Console.WriteLine($"[Vector ระยะห่าง] ลูกศรชี้ไปหาบอส: {directionToBoss}");
        Console.WriteLine($"[Vector ระยะห่าง] เจ้ายาแดงอยู่ห่างจากบอสทั้งหมด: {distanceToBoss} เมตร");
        
        // แอดวานซ์: ลอจิกตรวจสอบเงื่อนไขระยะห่างอันตราย
        if (distanceToBoss < 12f) // ปรับเป็น 12 เพื่อให้เงื่อนไขทำงานโชว์ใน Terminal
        {
            Console.WriteLine("⚠️ คำเตือน: บอสอยู่ใกล้เกินไปแล้ว! เตรียมรับแรงกระแทก!");
        }

        Console.WriteLine();
        Console.WriteLine("=== [จบการทดสอบ: ระบบคณิตศาสตร์เวกเตอร์พร้อมใช้งาน] ===");
    }
}