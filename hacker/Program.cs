using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ns4;
using ns57;
using ns63;
using System.Reflection;

namespace hacker {
	class Program {
		static void Main(string[] args) {
			var a = new ns58.Class907(128, "Editor Definition Database", ".HPTdb");
			var b = new Class901();
			var c = "Editor.hptdb";
			Class899<Class2122> class899_0 = new Class899<Class2122>(a, b, c);
			class899_0.method_5();
			var zzzz = class899_0.ilist_0.Select(zz => zz.method_0()).ToList();
			var summm = zzzz.Where(st => st.collection_0.Any(elem => elem.Contains("64AH"))).Select(found => found.collection_0.ToList()).ToList();
			var selectedStrat = zzzz.First(st => st.collection_0.Contains("68153764AH"));
			var dict = ns35.Class2514.idictionary_0;
			var abc = class899_0.ilist_0.Count();
		}
	}
}
