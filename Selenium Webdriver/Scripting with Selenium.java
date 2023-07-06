import io.github.bonigarcia.wdm.WebDriverManager;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class MyFirstSeleniumscript {
    public static void main (String [] args) throws InterruptedException {
        WebDriverManager.chromedriver().setup();
        WebDriver myDriver = new ChromeDriver();
        myDriver.manage().window().maximize();
        myDriver.get("https://www.google.com");
        String googlesource = myDriver.getPageSource();
        System.out.println("The source code for google is " + googlesource);
        String googlehandle = myDriver.getWindowHandle();
        System.out.println("The Unique ID is: " + googlehandle);
        String googletitle = myDriver.getTitle();
        System.out.println("The Title of the google page is " + googletitle);
        myDriver.navigate().to("https://www.udemy.com");
        String udemytitle = myDriver.getTitle();
        System.out.println("The title for thr Udemy page is" + udemytitle);
        myDriver.navigate().back();
        myDriver.navigate().refresh();
        myDriver.getCurrentUrl();
        String currenturl = myDriver.getCurrentUrl();
        System.out.println("The current url is: "+ currenturl);
        myDriver.navigate().forward();
        Thread.sleep(3000);
        myDriver.quit();
    }
}
