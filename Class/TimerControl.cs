using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Toolkit.Uwp.Notifications;

namespace ProjectPT_Remaster.Class
{
    public class TimerControl
    {
        private static Timer aTimer;
        private static readonly double cycleTime = 1000; // 1초

        private static DateTime yesterdayDate = DateTime.ParseExact(DateTime.Now.AddDays(-1).ToString("yyyyMMdd"), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
        private static string sendTime = "080000";
        private static string Infomation;

        public static void TimerMain(string ReceviedTime, string ReceviedInfomation)
        {
            sendTime = ReceviedTime;
            Infomation = ReceviedInfomation;
            SetTimer();
        }
        public static void TimerStop()
        {
            aTimer.Stop();
            aTimer.Dispose();
        }

        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(cycleTime);
            
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            DateTime todayDate = DateTime.ParseExact(DateTime.Now.ToString("yyyyMMdd"), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime nowTime = DateTime.ParseExact(DateTime.Now.ToString("HHmmss"), "HHmmss", System.Globalization.CultureInfo.InvariantCulture);
            DateTime setTime = DateTime.ParseExact(sendTime, "HHmmss", System.Globalization.CultureInfo.InvariantCulture);

            if (todayDate > yesterdayDate)
            {
                if (nowTime >= setTime)
                {
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("약 알림")
                        .AddText(Infomation)
                        .Show();
                }

                yesterdayDate = todayDate;
            }
        }
    }
}
