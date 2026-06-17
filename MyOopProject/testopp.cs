using System;

// 1. สร้าง "แม่พิมพ์" (Class) ของตัวละครในเกม
public class GameCharacter
{
    // Properties: ข้อมูลติดตัวของตัวละคร
    public string Name { get; set; }
    public int HP { get; set; }
    public int AttackPower { get; set; }

    // Constructor: ฟังก์ชันสำหรับปั๊มตัวละครใหม่ (ต้องส่ง ชื่อ, เลือด, พลังโจมตี เข้ามา)
    public GameCharacter(string name, int hp, int attackPower)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
    }

    // Method: พฤติกรรมหรือคำสั่งที่ตัวละครนี้ทำได้
    public void Attack(GameCharacter target)
    {
        Console.WriteLine($"{Name} โจมตี {target.Name} อย่างแรง!");
        target.HP -= AttackPower;
        Console.WriteLine($"{target.Name} เหลือ HP: {target.HP}");
    }
}

class Program
{
    static void Main()
    {
        // 2. ปั๊ม "วัตถุจริง" (Objects) ออกมาจากแม่พิมพ์
        GameCharacter player = new GameCharacter("Hero", 100, 25);
        GameCharacter monster1 = new GameCharacter("Goblin A", 40, 10);
        GameCharacter monster2 = new GameCharacter("Goblin B", 40, 10);

        // 3. เอา Objects ไปใส่ใน Array (เนียนทำงานร่วมกัน)
        // สมมติเป็น Array รวมฝั่งศัตรูในฉาก
        GameCharacter[] enemyWave = new GameCharacter[] { monster1, monster2 };

        // ลองให้ผู้เล่นโจมตีศัตรูตัวแรกใน Array
        player.Attack(enemyWave[0]); 
    }
}