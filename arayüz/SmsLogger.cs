using System;

namespace arayüzler
{
    
    public class SmsLogger:ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("sms olarak yazar");

        }
    }



    
    
}