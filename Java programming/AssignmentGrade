//Programming with Java
package Part1;


import java.util.Scanner;

public class AssignmentGrade {
    public static void main (String [] args){

        System.out.println("Hello Tester");

        //Initialize what we know
        int assignment_total = 40;
        int exam_total = 200;
        int assignment_grade;
        int exam_grade;

        //Get input from user
        System.out.println("Enter your total assignment grade");
        Scanner userInput = new Scanner(System.in);
        assignment_grade = userInput.nextInt();
        System.out.println("Enter your exam grade");
        exam_grade = userInput.nextInt();

        // Processing

        int student_grade = assignment_grade + exam_grade;
        int total = assignment_total + exam_total;
        float percentage = (float) student_grade/total * 100;

        //Print output

        System.out.println("your total grade is " + student_grade);
        System.out.println("your percentage is " + percentage);


    }
}

