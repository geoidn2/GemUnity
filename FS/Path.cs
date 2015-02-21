﻿using System;
using System.Diagnostics;
using System.IO;

namespace Gem
{
	[DebuggerDisplay("Path = {mValue}")]
	[Serializable]
	public struct Path_
	{
		private readonly string mValue;

		public Path_(string _path)
		{
			if (string.IsNullOrEmpty(_path))
				L.W(L.M.SHOULD_NOT_NULL("path"));
			mValue = _path;
		}

		public static implicit operator string(Path_ _this)
		{
			return _this.mValue;
		}

		public static Path_ operator /(Path_ _this, string _append)
		{
			return new Path_(_this.mValue + "/" + _append);
		}
	}

	[DebuggerDisplay("Path = {mValue}")]
	[Serializable]
	public struct FullPath
	{
		private readonly string mValue;

		public FullPath(string _path)
		{
			if (string.IsNullOrEmpty(_path))
				L.W(L.M.SHOULD_NOT_NULL("path"));
			mValue = _path;
		}

		public bool Exists()
		{
			return File.Exists(mValue);
		}

		public static implicit operator string(FullPath _this)
		{
			return _this.mValue;
		}
	}

}