using System;
using System.Collections.Generic;
using AlarmWorkflow.Shared.Core;
using AlarmWorkflow.Shared.Extensibility;
using AlarmWorkflow.Shared.Specialized;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlarmWorkflow.Parser.Library
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IParser p = new LSFuldaParser();
            IList<string> analyzedLines = new List<string>();

            ReplaceDictionary replDict = C:\Users\wl112\source\repos\AlarmWorkflow\AlarmSources\Mail\MailAlarmSource.cs_configuration.ReplaceDictionary;

            foreach (string preParsedLine in parsedLines)
            {
                analyzedLines.Add(replDict.ReplaceInString(preParsedLine));
            }

            Operation operation = null;
            try
            {
                Logger.Instance.LogFormat(LogType.Trace, this, Properties.Resources.BeginParsingIncomingOperation);

                string[] lines = analyzedLines.ToArray();

                if (!_serviceProvider.GetService<IAlarmFilter>().QueryAcceptSource(string.Join(" ", lines)))
                {
                    return;
                }

                Stopwatch sw = Stopwatch.StartNew();

                operation = _parser.Parse(lines);

                sw.Stop();
                Logger.Instance.LogFormat(LogType.Trace, this, Properties.Resources.ParsingOperationCompleted, sw.ElapsedMilliseconds);

                // If there is no timestamp, use the current time. Not too good but better than MinValue :-/
                if (operation.Timestamp == DateTime.MinValue)
                {
                    Logger.Instance.LogFormat(LogType.Warning, this, Properties.Resources.ParsingTimestampFailedUsingCurrentTime);
                    operation.Timestamp = DateTime.Now;
                }

                IDictionary<string, object> ctxParameters = new Dictionary<string, object>();
                ctxParameters[ContextParameterKeys.ArchivedFilePath] = archivedFilePath;
                ctxParameters[ContextParameterKeys.ImagePath] = file.FullName;

                AlarmSourceEventArgs args = new AlarmSourceEventArgs(operation);
                args.Parameters = ctxParameters;

                OnNewAlarm(args);
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Warning, this, Properties.Resources.ProcessNewImageError);
                Logger.Instance.LogException(this, ex);
            }

            Operation o = p.Parse(new[] { "" });
            Assert.AreEqual("S 6.2 123456 11", o.OperationNumber);
            Assert.AreEqual("Entenhausen", o.Einsatzort.City);
            Assert.AreEqual(48.2, o.Einsatzort.GeoLatitude, 0.02);
            Assert.AreEqual(11.42, o.Einsatzort.GeoLongitude, 0.02);
        }
    }
}
