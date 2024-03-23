using System;
using System.Collections.Generic;


public class Logger{
        private static Logger? instance ;
        private List <string> messages ;
        private static readonly object lockObject = new object();
        

        private Logger (){
            messages = new List<string>();

        }
        public static Logger GetInstance(){

            lock (lockObject){
                if(instance == null){
                    instance = new Logger();
                }
            }
            return instance;
        }

        public void LogMessage(string message){
            messages.Add(message);
        }

    public List<string> GetMessages(){
        return messages;
    }

}
class Program {
    static void Main(string[] args){
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();
        Logger logger3 = Logger.GetInstance();


        logger1.LogMessage("Cos1");
        logger2.LogMessage("Cos 2");
        logger3.LogMessage("Jarek to wyswietla");


        Console.WriteLine(logger1== logger2 && logger3 == logger1);

        foreach(var message in logger1.GetMessages()){
            Console.WriteLine(message);
            
        }
    }
}