package Part1;
//Allow users from 13 and above to register. Restrict other users.
import java.util.Scanner;

public class statementS {
    public static void main(String[] args) {
        Scanner userinput = new Scanner(System.in);
        int age;
        System.out.println("Enter your age");
        age = userinput.nextInt();
        if (age >= 13)
            System.out.println(" You are eligible to register to the website");
        else
            System.out.println("Sorry, you are too young to register");


        //Salary reductions
        System.out.println("Enter your salary");
        int salary;
        salary = userinput.nextInt();
        if (salary >= 4000 && salary <= 5000)
            System.out.println("Your salary won't have any reductions");
        else if (salary == 6000)
            System.out.println("You will get a tax of 10%");
        else
            System.out.println("You will get a 20% tax");


        // valid age

        if (age > 0)
            if (age >= 18)
                System.out.println("Welcome to the website");
            else
                System.out.println("you cant register");
        else
            System.out.println("Invalid value for age.");


        //Switch statement
        int x = 3;
        int y = 5;
        System.out.println("Choose 1 for addition, 2 for multiplication and 3 for subtraction");
        int choice = userinput.nextInt();
        switch (choice) {
            case 1:
                System.out.println("addition" + (x + y));
                break;
            case 2:
                System.out.println("Multiplication" + (x * y));
                break;
            case 3:
                System.out.println("Subtraction" + (x - y));
                break;
            default:
                System.out.println(" Wrong choice input");
        }

        for (int i = 0; i<5; i++)
        {
            System.out.println("Hello Recruiter");
            System.out.println("The value of i is" + i);
            }

        while (x <= 5)
        {
            System.out.println(x);
            x++;
        }
        userinput.close();

        int z = 1;
        do
        {
            System.out.println("The value of z is " + z);
            z++;
        }
        while (z <= 9);
        }
    }

