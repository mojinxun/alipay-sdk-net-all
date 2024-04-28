﻿using System;
using System.Collections.Generic;
using System.Collections;
using Aop.Api.Parser;
using Newtonsoft.Json;

namespace Aop.Api
{
    /// <summary>
    /// 符合AOP习惯的纯字符串字典结构。
    /// </summary>
    public class AopDictionary : Dictionary<string, string>
    {
        private const string DATE_TIME_FORMAT = "yyyy-MM-dd HH:mm:ss";

        public AopDictionary() { }

        public AopDictionary(IDictionary<string, string> dictionary)
            : base(dictionary)
        { }

        public void AddAll(Dictionary<string, string> textParams)
        {
            foreach (var param in textParams)
            {
                this.Add(param.Key, param.Value);
            }
        }

        /// <summary>
        /// 添加一个新的键值对。空键或者空值的键值对将会被忽略。
        /// </summary>
        /// <param name="key">键名称</param>
        /// <param name="value">键对应的值，目前支持：string, int, long, double, bool, DateTime类型</param>
        public void Add(string key, object value)
        {
            string strValue;

            if (value == null)
            {
                strValue = null;
            }
            else if (value is string)
            {
                strValue = (string)value;
            }
            else if (value is Nullable<DateTime>)
            {
                Nullable<DateTime> dateTime = value as Nullable<DateTime>;
                strValue = dateTime.Value.ToString(DATE_TIME_FORMAT);
            }
            else if (value is Nullable<int>)
            {
                strValue = (value as Nullable<int>).Value.ToString();
            }
            else if (value is Nullable<long>)
            {
                strValue = (value as Nullable<long>).Value.ToString();
            }
            else if (value is Nullable<double>)
            {
                strValue = (value as Nullable<double>).Value.ToString();
            }
            else if (value is Nullable<bool>)
            {
                strValue = (value as Nullable<bool>).Value.ToString().ToLower();
            }
            else if (value is ICollection)
            {
                AopModelParser parser = new AopModelParser();
                object jo = parser.serializeArrayValue(value as ICollection);

                JsonSerializerSettings jsetting = new JsonSerializerSettings();
                jsetting.NullValueHandling = NullValueHandling.Ignore;
                strValue = JsonConvert.SerializeObject(jo, Formatting.None, jsetting);
            }
            else if (value is AopObject)
            {
                AopModelParser parser = new AopModelParser();
                object jo = parser.serializeAopObject(value as AopObject);

                JsonSerializerSettings jsetting = new JsonSerializerSettings();
                jsetting.NullValueHandling = NullValueHandling.Ignore;
                strValue = JsonConvert.SerializeObject(jo, Formatting.None, jsetting);
            }
            else
            {
                strValue = value.ToString();
            }

            this.Add(key, strValue);
        }

        public new void Add(string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                base.Add(key, value);
            }
        }
    }
}
