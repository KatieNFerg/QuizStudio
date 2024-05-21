

//Topic: Prairie Dogs- 10 total Points
//4 Multiple Choice
//4 True/False
//1 Check Boxes (2 answer) 
using System.Xml.XPath;

public class Question 
{
    string TypeOfQuestion { get; set; }
    public static int Result { get; set; } //number to start count ++
    public static string CorrectAnswer {get; set; } //
    public static string UserAnswer { get; set; } 
    // {
      /*  TypeOfQuestion = typeOfQuestion;
        Result = result;
        this.CorrectAnswer = correctAnswer;
        UserAnswer = userAnswer;*/

    // }
    public string askUserQuestion()
    {
        
        // string correctAnswer = CorrectAnswer;
        string typeOfQuestion = TypeOfQuestion;
        string correctAnswer = CorrectAnswer;
        int result = Result;
        string userAnswer = Console.ReadLine();
       // TypeOfQuestion = typeOfQuestion;
        if (userAnswer == "")
        {
            result = 0;
        }
        else if (userAnswer == correctAnswer)
        {
            result++;
        }
        return result.ToString();
    }

    public static int gradeResults()
    {
        int result = Result;
        return (result / 10) * 100;
    }
}