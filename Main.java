public class Program
{
    public static void main(String[] args) {
        int x = 1;
        int y = 1;
        System.out.print(x + " " + y);
        
        for(int i = 0; i < 20; i++){
            int sum = x + y;
            System.out.print(" " + sum);
            x = y;
            y = sum;
            
        }
    }
}
