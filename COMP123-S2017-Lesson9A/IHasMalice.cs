using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Saksham Tejpal
 * Date: July 13, 2017
 * Description: This is an Interface that defines a Malice Property that
 * must be implemented in any class that subscribes to it.
 * Version: 0.1 - Created IHasMalice interface
 */

namespace COMP123_S2017_Lesson9A
{
	/// <summary>
	/// This is the IHasMalice Interface
	/// </summary>
	public interface IHasMalice
	{
		// PUBLIC PROPERTIES
		int Karma { get; set; }
	}
}