﻿/*
 * 用户： 张晓松
 * 日期: 2018/8/25
 * 时间: 17:00
 */
using System;
using FlexibleMVC.IServer;

namespace FlexibleMVC.Demo.Plugin
{
	/// <summary>
	/// Description of Add.
	/// </summary>
	public class Add : IOperation
	{
		public int Operate(int left, int right)
		{
			return left + right;
		}
	}
}
