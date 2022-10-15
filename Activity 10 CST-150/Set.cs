using Baseline.ImTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Activity_10_CST_150
{
    internal class Set
    {
        private List<int> elements;
        public Set() { elements = new List<int>(); }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else {
                elements.Add(val);
                return true;
            }
        }
        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i]) return true;

                // [ERROR] else return false; 
                /* [REASON] The else case has been removed because it is an invalid case in this context.
                 *  An else statement is not used to do condition checking and should not be used in the
                 *  same manner as if or if else. Else is intended to execute alternative code in circumstances
                 *  where if and else if conditions return false. Attempting to use it in this context
                 * will produce unwanted results. */

            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            { str += i + " "; }
            return str; }
        public void clearSet()
        { elements.Clear(); }

            /* [LOGIC ERROR] 
           COMMENTED OUT METHOD: 

            * public Set union(Set rhs )        
            * {                       
            * for(int i = 0; i < rhs.elements.Count; i++)            
            * {                
            * this.addElement( rhs.elements[ i ] );            
            * }                       
            * return rhs;        
            * }    
            * }
            * }
            
            [REASON]
            In order to produce the desired results, we must be able to compare our union
            set to our existing elements in the program. The previous method 
            would not produce the desired results. */

        public Set union(Set rhs)

        {

            // Create a new set. Set C will be our union set. 
            Set c = new Set();

            // Iterate
            for (int i = 0; i < elements.Count; i++)
            {
                if (!c.containsElement(elements[i]))
                { // If 'c' does not contain the existing list element, then add it to c.
                    c.addElement(elements[i]);
                }
            }

            // Iterate through the passed object's elements list
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                if (!c.containsElement(rhs.elements[i]))
                { // If the list 'c' does not contain the current element of the passed object's list add the current element to the set. 
                    c.addElement(rhs.elements[i]);
                }
            }

            return c; // Return the set. 

        }

    }

}



