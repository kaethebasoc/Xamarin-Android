using System;
using System.IO;
using System.Collections.Generic;

namespace QuickNote
{
	public class DatabaseManager
	{
		static string dbName = "QuickNote.sqlite";
		string dbPath = Path.Combine (Android.OS.Environment.ExternalStorageDirectory.ToString (), dbName);

		public List<NoteTable> ViewAll()
		{
			try
			{
				using (var conn = new SQLite.SQLiteConnection (dbPath)) {
					var cmd = new SQLite.SQLiteCommand (conn);
					cmd.CommandText = "select * from tblQuickMemo";
					var NoteList = cmd.ExecuteQuery<NoteTable> ();
					return NoteList;
				}

			} catch(Exception e) {
				Console.WriteLine ("Error:" + e.Message);
				return null;
			}
		}

		public void AddItem(string title,string details)
		{
			try
			{
				using (var conn = new SQLite.SQLiteConnection (dbPath)) {
					var cmd = new SQLite.SQLiteCommand (conn);
					cmd.CommandText = "insert into tblQuickMemo(Title,Details) values('" + title + "','" + details + "')" ;
					cmd.ExecuteNonQuery();
				}

			} catch(Exception e) {
				Console.WriteLine ("Error:" + e.Message);
			}
		}

		public void ViewItem(string title,string details,int listid)
		{
			try
			{
				using (var conn = new SQLite.SQLiteConnection (dbPath)) {
					var cmd = new SQLite.SQLiteCommand (conn);
					cmd.CommandText = "update tblQuickMemo set Title='" + title + "', Details='" + details + "' where Listid=" + listid ;
					cmd.ExecuteNonQuery();
				}

			} catch(Exception e) {
				Console.WriteLine ("Error:" + e.Message);
			}
		}

		public void DeleteItem(int listid)
		{
			try
			{
				using (var conn = new SQLite.SQLiteConnection (dbPath)) {
					var cmd = new SQLite.SQLiteCommand (conn);
					cmd.CommandText = "delete from tblQuickMemo where Listid = " + listid ;
					cmd.ExecuteNonQuery();
				}

			} catch(Exception ex) {
				Console.WriteLine ("Error:" + ex.Message);
			}
		}
			
		public List<NoteTable> MoveNext (int listid)
		{
			try {
				using (var conn = new SQLite.SQLiteConnection (dbPath)) {
					var cmd = new SQLite.SQLiteCommand (conn);
					//cmd.CommandText = "select count(ListId) from tblQuickMemo;
					cmd.CommandText = "select * from tblQuickMemo where Listid = " + listid ;
					var NoteList = cmd.ExecuteQuery<NoteTable> ();
					return NoteList;
				}
			} catch(Exception e) {
				Console.WriteLine ("Error:" + e.Message);
				return null;
			}
		}

		public void EditItem(string title,string details,int listid)
		{
			try
			{
				using (var conn = new SQLite.SQLiteConnection (dbPath)) {
					var cmd = new SQLite.SQLiteCommand (conn);
					cmd.CommandText = "update tblQuickMemo set Title='" + title + "', Details='" + details + "' where Listid=" + listid ;
					cmd.ExecuteNonQuery();
				}

			} catch(Exception e) {
				Console.WriteLine ("Error:" + e.Message);
			}
		}

	}
}