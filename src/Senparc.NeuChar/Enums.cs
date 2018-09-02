﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Senparc.NeuChar
{
    public enum DataType
    {
        List,
        Unique
    }

    public enum ApiType
    {
        AccessToken,
        Normal
    }

    /// <summary>
    /// NeuChar 消息的乐行
    /// </summary>
    public enum NeuCharMessageType
    {
        /// <summary>
        /// 获取配置
        /// </summary>
        GetConfig,
        /// <summary>
        /// 储存配置
        /// </summary>
        SaveConfig,
    }


    /// <summary>
    /// AppStore状态
    /// </summary>
    public enum AppStoreState
    {
        /// <summary>
        /// 无状态
        /// </summary>
        None = 1,
        /// <summary>
        /// 已进入应用状态
        /// </summary>
        Enter = 2,
        /// <summary>
        /// 退出App状态（临时传输状态，退出后即为None）
        /// </summary>
        Exit = 4
    }


    /// <summary>
    /// 消息请求类型
    /// </summary>
    public enum RequestMsgType
    {
        Unknown = -1,//未知类型
        Text = 0, //文本
        Location = 1, //地理位置
        Image = 2, //图片
        Voice = 3, //语音
        Video = 4, //视频
        Link = 5, //连接信息
        ShortVideo = 6,//小视频
        Event = 7, //事件推送
        File = 8,//文件类型

        //NeuChar = 99//NeuChar请求
    }

    /// <summary>
    /// 消息响应类型
    /// </summary>
    public enum ResponseMsgType
    {
        [Description("未知")]
        Unknown = -1,//未知类型
        [Description("文本")]
        Text = 0,
        [Description("单图文")]
        News = 1,
        [Description("音乐")]
        Music = 2,
        [Description("图片")]
        Image = 3,
        [Description("语音")]
        Voice = 4,
        [Description("视频")]
        Video = 5,
        [Description("多客服")]
        Transfer_Customer_Service,
        //transfer_customer_service

        //以下为延伸类型，微信官方并未提供具体的回复类型
        [Description("多图文")]
        MultipleNews = 106,
        [Description("位置")]
        LocationMessage = 107,//
        [Description("无回复")]
        NoResponse = 110,
        [Description("success")]
        SuccessResponse = 200

    }

}