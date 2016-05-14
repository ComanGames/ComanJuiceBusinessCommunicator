﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace ComanJuiceBusinessCommunicator
{
    public static class SerializationUtilities
    {
        private static string _folder = @"C:\Temp\data";
        private static string _file = @"\textData.xml";
        public  static BotMessageData LoadData()
        {
            if(!File.Exists(_folder+_file))
                return new BotMessageData();

            bool weHaveProblem = false;
            FileStream fileStream = null;
            do
            {
                weHaveProblem = false;
                try
                {

                    fileStream = File.Open(_folder + _file, FileMode.Open);
                }
                catch (Exception)
                {
                    weHaveProblem = true;
                }

            } while (weHaveProblem);
            XmlSerializer serializer = new XmlSerializer(typeof(BotMessageData));
            BotMessageData data = serializer.Deserialize(fileStream) as BotMessageData;

            fileStream.Close();
            return data;
        }
        public static void SaveData(BotMessageData data)
        {
            if (!Directory.Exists(_folder))
            {
                Directory.CreateDirectory(_folder);
            }
            bool weHaveProblem ;
            FileStream fileStream = null;
            do
            {
                weHaveProblem = false;
                try
                {

                    fileStream = File.Open(_folder + _file,FileMode.OpenOrCreate);
                }
                catch (Exception)
                {
                    weHaveProblem = true;
                }
                
            } while (weHaveProblem);
            XmlSerializer serializer = new XmlSerializer(typeof(BotMessageData));
            serializer.Serialize(fileStream, data);
            fileStream.Close();

        }
    }
}