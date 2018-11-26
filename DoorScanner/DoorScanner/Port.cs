/*
 * Created by SharpDevelop.
 * User: Aitor
 * Date: 11/11/2018
 * Time: 17:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DoorScanner
{
	/// <summary>
	/// Description of Port.
	/// </summary>
	[Serializable]
	public class Port
	{
		int NumPort;
		string State;
		string Protocole;
		string Service;
		
		//-----GETTER AND SETTER-----
		public int numport
		{
			get{return NumPort;}
			set{NumPort=value;}
		}
		public string state
		{
			get{return State;}
			set{State=value;}
		}
		public string protocole
		{
			get{return Protocole;}
			set{Protocole=value;}
		}
		public string service
		{
			get{return Service;}
			set{Service=value;}
		}
		
		
		//-----Constructeurs-----
		public Port()
		{
		}
		
		public Port(int cnumport, string cstate, string cprotocole, string cservice)
		{
			numport = cnumport;
			state = cstate;
			protocole = cprotocole;
			service = cservice;
		}
		
		//-----Functions-----
		public string showForSave(){
			return "Port : "+numport+", State: "+state+", Proto: "+protocole+", Service: "+service+".";
		}
		
	}
}
