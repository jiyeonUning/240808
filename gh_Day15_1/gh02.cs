using System;
using System.Reflection.Metadata;

namespace gh_Day15_1
{
    /********************************************************************************************************************************
    
      *  과제 2. 빌더패턴 활용하기
    
         이번 강의에선 빌더패턴의 예시로, 게임에 필요한 오브젝트를 생성하는 코드를 다루었었습니다.
         해당 개념을 참고하여, 원하는 Builder클래스를 만들고, 빌더를 통해서 다양한 객체를 생성해보세요.
         아래는 예시입니다. 예시를 참고하여 원하는 Builder를 만들어 보세요.

      1. MonsterBuilder 클래스를 만들어 몬스터의 이름, 외형, 전리품, 경험치, 공격범위, 전투스타일 등을 조합하여
         여러 유형의 Monster들을 만들 수 있습니다.

      2. AnimalBuilder 클래스를 만들어 동물의 이름, 외형, 생산품, 울음소리, 사료종류, 등을 조합하여
         여러 유형의 Animal들을 만들 수 있습니다.

      3. UnitBuilder 클래스를 만들어 유닛의 이름, 이동방법, 공격타입, 방어타입, 생산가격 등을 조합하여
         여러 유형의 Unit들을 만들 수 있습니다.

    
     ********************************************************************************************************************************/

    // 판타지 직업 클래스
    public class Job
    {
        public string name;
        public int takeJobLevel;
        public string useWeapon;
        public string useArmor;
        public int plusHP;
    }


    // 판타지 직업 생성기
    public class JobBuilder
    {
        //기본 정보
        public string name;        // 직업명
        public int takeJobLevel;   // 직업을 받을 수 있는 레벨
        public string useWeapon;   // 각 직업의 전용 무기
        public string useArmor;    // 각 직업의 전용 장비
        public int plusHP;         // 각 직업이 되었을 경우, 더해지는 추가 체력 보정치

        // 기본값 입력
        public JobBuilder()
        {
            name = "모험가";
            takeJobLevel = 10;
            useWeapon = "검";
            useArmor = "여행복";
            plusHP = 10;
        }

        // Build 함수 생성
        public Job Build()
        {
            Job job = new Job();
            job.name = name;
            job.takeJobLevel = takeJobLevel;
            job.useWeapon = useWeapon;
            job.useArmor = useArmor;
            job.plusHP = plusHP;
            return job;
        }

        // 필드값을 변경할 수 있도록 해주는 함수들을 생성
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetTakeJobLevel(int takeJobLevel)
        {
            this.takeJobLevel = takeJobLevel;
        }
        public void SetUseWeapon(string useWeapon)
        {
            this.useWeapon = useWeapon;
        }
        public void SetArmor(string useArmor)
        {
            this.useArmor = useArmor;
        }
        public void SetPlusHP(int plusHP)
        {
            this.plusHP = plusHP;
        }
    }

    // 직업 종류 : 나이트, 기공사, 백마도사
    public class gh02
    {
        static void Main(string[] args)
        {
            JobBuilder NightjobBuilder = new JobBuilder();     // 나이트
            JobBuilder MachinistjobBuilder = new JobBuilder(); // 기공사
            JobBuilder WhiteMagejobBuilder = new JobBuilder(); // 백마도사

            NightjobBuilder.SetName("나이트");
            NightjobBuilder.SetUseWeapon("검, 방패");
            NightjobBuilder.SetArmor("갑옷");
            NightjobBuilder.SetPlusHP(100);

            MachinistjobBuilder.SetName("기공사");
            MachinistjobBuilder.SetTakeJobLevel(50);
            MachinistjobBuilder.SetUseWeapon("총기류");
            MachinistjobBuilder.SetArmor("기계공의 작업복");
            MachinistjobBuilder.SetPlusHP(50);

            WhiteMagejobBuilder.SetName("백마도사");
            WhiteMagejobBuilder.SetUseWeapon("스태프");
            WhiteMagejobBuilder.SetArmor("사제복");
            WhiteMagejobBuilder.SetPlusHP(30);

            Console.WriteLine();
            Console.WriteLine("다음 보기에서 전직할 직업을 선택해주세요.");
            Console.WriteLine();
            Console.WriteLine($"1. {NightjobBuilder.name}");
            Console.WriteLine($"2. {MachinistjobBuilder.name}");
            Console.WriteLine($"3. {WhiteMagejobBuilder.name}");
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.Write("입력 : ");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine($"{NightjobBuilder.name}을(를) 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine("< 직업 정보 >");
                    Console.WriteLine($"{NightjobBuilder.name} | {NightjobBuilder.takeJobLevel}레벨부터 시작 \n전용무기 : {NightjobBuilder.useWeapon} \n전용 장비 : {NightjobBuilder.useArmor} \n체력 보정치 : {NightjobBuilder.plusHP} ");
                    break;
                case 2:
                    Console.WriteLine($"{MachinistjobBuilder.name}을(를) 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine("< 직업 정보 >");
                    Console.WriteLine($"{MachinistjobBuilder.name} | {MachinistjobBuilder.takeJobLevel}레벨부터 시작 \n전용무기 : {MachinistjobBuilder.useWeapon} \n전용 장비 : {MachinistjobBuilder.useArmor} \n체력 보정치 : {MachinistjobBuilder.plusHP} ");
                    break;
                case 3:
                    Console.WriteLine($"{WhiteMagejobBuilder.name}을(를) 선택하셨습니다.");
                    Console.WriteLine();
                    Console.WriteLine("< 직업 정보 >");
                    Console.WriteLine($"{WhiteMagejobBuilder.name} | {WhiteMagejobBuilder.takeJobLevel}레벨부터 시작 \n전용무기 : {WhiteMagejobBuilder.useWeapon} \n전용 장비 : {WhiteMagejobBuilder.useArmor} \n체력 보정치 : {WhiteMagejobBuilder.plusHP} ");
                    break;
            }
        }
    }
}
