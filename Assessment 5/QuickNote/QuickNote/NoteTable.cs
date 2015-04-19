using System;
using SQLite;

namespace QuickNote
{
	public class NoteTable
	{

		[PrimaryKey, AutoIncrement]
		public int ListId { get; set; }
		public string Title{ get; set; }
		public string Details{ get; set; }
		public DateTime Date { get; set;}

		public NoteTable ()
		{
		}
	}
}

