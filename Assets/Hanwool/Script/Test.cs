//05.13 ~ 05.16
using UnityEngine;
using System;
public class Test : MonoBehaviour
{
    public float moveSpeed = 10f;


    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))// 앞으로 가는 기능
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))// 왼쪽으로 가는 기능
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))// 뒤로로 가는 기능
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))// 오른쪽으로로 가는 기능
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        
    }
    
    
    
    /*
    class Player
    {  
        public string name = "";
        public int level = 1;
        public int maxLevel= 10;
        /*
        public Player(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        public ~Player()
        {

        }
        
        public void LevelUp()
        {
            //level = level +1;
            if(level < maxLevel)
            {
                level++;
                Console.WriteLine($"{name}캐럭터 업!, 현재 레밸{level}");
            }
            else
            {
                Console.WriteLine($"더이상 랩업할 수 없습니다! 만랩입니다!");   
            }
        }
        /*
        public void CreatePlayer(string name, int level)
        {
            this.name = name;
            this.level= level;
            Console.WriteLine("캐릭터 : " + name + ", 레벨 : " + level + "생성 완료");
            Console.WriteLine($"캐릭터 : {name}, 레벨 : {level} 생성 완료");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Game1",1); 
            Player player2 = new Player("Game2",2);
            Player player3 = new Player("Game2",2);
            Player player4 = new Player("Game2",2);
            Player player5 = new Player("Game2",2);
            
            // Player 배열 방식
            Player[] players = {player1,player2,player3,player4,player5};
          //타입[]    배열 이름
            // Player 리스트 방식
            List<Player> playerList = new List<Player>();
          // List<타입>     리스트이름  =   new List<타입>();
            playerlist.Add(player1);
            playerlist.Add(player2);
            playerlist.Add(player3);
            playerlist.Add(player4);
            playerlist.Add(player5);

            Console.WriteLine($"현재 플레이어 수는 {players.Length}입니다.")
            Console.WriteLine($"현재 플레이어 수는 {playerList.Count}입니다.")
                
            player1.LevelUp();
            //player1.name ="hanwool"
            //player1.level = 3;
           //player1.CreatePlayer("Game1",1);
            //player1.name ="wool"
            //player1.level = 50;
            //player1.CreatePlayer("Game2",2);
            
        
        }
        /*
        int number = 10;
    //  데이터타입 이름 대입 값 
        Console.WriteLine(number);
    
    string str = "Hello World!";
    Console.WriteLine(str);

    // 숫자 타입   
    int number1 = 0;
    int number2 = 1;

    float number3 = 0.3f
    float number4 = 10.0f
    float number5 = 0.0f;

    double number6 = 0.3d;
    double number7 = 10.123d;
    double number8 = -3.7d;

    // 논리 타입
    bool ison = true;
    bool isMute - false;

    // 문자 타입
    char character1 = 'a';
    char character2 = '안';

    string str1 = "a";
    string str2 = "HI yo";4
    }
    
    
    }
    */
}
