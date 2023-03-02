using System; 
class Program{
    static void Main(string[] args) {
        Console.Write("Please input your ID number : ");
        int u = int.Parse(Console.ReadLine());
        Console.Write("Input your agency : ");
        string q = (Console.ReadLine());

        if(u <= 999999 && u >= 0){
            int x = u % 10;
            int x1 = u / 10 % 10;
            int x2 = u / 100 % 10;
            int x3 = u / 1000 % 10;
            int x4 = u / 10000 % 10;    
            int x5 = u / 100000;
            
        switch(q){
            case"CIA":
            if(x3 >= 6 && x3 != 8 && x1 != 1 && x1 != 3 && x1 != 5 && x % 3 == 0){
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
            break;
            case"FBI":
            if(x4 % 2 != 0 && x2 != 6 && x2 % 2 == 0 && x5 >= 4 && x5 <= 7){
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
            break;
            case"NSA":
            if(30 % x == 0 && x2 % 3 == 0 && x2 % 2 == 1 && x == 7 || x1 == 7 || x2 == 7 || x3 == 7 || x4 == 7 || x5 == 7){
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            }
            break;
            default:
            Console.WriteLine("False");
            break;
        }
    }

}
}