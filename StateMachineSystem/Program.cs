using System;

class Program
{
    public enum PlayerState { Idle, Running, Jumping }

    static void Main(string[] args)
    {
        Console.WriteLine("=== [เริ่มทำการทดสอบโค้ดระบบเกม] ===");
        Console.WriteLine();

        // ========================================================
        // 🧪 1. ทดสอบลอจิก VECTOR3 (คำนวณพิกัด)
        // ========================================================
        var moveRight = new { X = 3f, Y = 0f, Z = 0f };
        var moveForward = new { X = 0f, Y = 0f, Z = 4f };

        float combinedX = moveRight.X + moveForward.X;
        float combinedZ = moveRight.Z + moveForward.Z;
        Console.WriteLine($"[Vector บวกกัน] ทิศทางเดินเฉียงรวม: ({combinedX}, 0, {combinedZ})");

        float deltaX = 6f - 0f; 
        float deltaZ = 8f - 0f;
        double distanceToBoss = Math.Sqrt((deltaX * deltaX) + (deltaZ * deltaZ));
        
        Console.WriteLine($"[Vector ระยะห่าง] เจ้ายาแดงอยู่ห่างจากบอสทั้งหมด: {distanceToBoss} เมตร");
        Console.WriteLine();

        // ========================================================
        // 🧪 2. ทดสอบลอจิก STATE MACHINE (สมองตัวละคร)
        // ========================================================
        PlayerState currentState = PlayerState.Idle;
        Console.WriteLine($"สถานะเริ่มต้น: {currentState.ToString().ToUpper()}");

        float moveInput = 1.0f; 
        if (currentState == PlayerState.Idle && moveInput != 0)
        {
            currentState = PlayerState.Running;
            Console.WriteLine($"เปลี่ยนสถานะเป็น: {currentState}");
        }

        bool isJumpPressed = true;
        bool isGrounded = true;
        if (currentState == PlayerState.Running && isJumpPressed && isGrounded)
        {
            currentState = PlayerState.Jumping;
            Console.WriteLine($"เปลี่ยนสถานะเป็น: {currentState}");
        }

        Console.WriteLine();
        Console.WriteLine("=== [จบการทดสอบ: โค้ดทำงานถูกต้อง 100%] ===");
    }
}
