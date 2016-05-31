using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Template_Lesson4
{

    /**
 *<summary>
 * This is the course class - we are using this as a custome datta for our Teacher and Student classws
 * </summary> 
 * 
 * @class Cours
 * 
 
 */
    class Course
    {

        //PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++
        private string _code;
        private string _description;


            //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++
            public string Code
        {

            get
            {
                return this._code;

            }

            set
            {
                this._code = value;

            }
        }

        public string Description
        {

            get
            {
                return this._description;

            }

            set
            {
                this._description = value;

            }
        }



        //CONTSRUCTOR+++++++++++++++++++++++++++++++++++++++++++
        /**
 *<summary>
 * This constructor takes two parameters: Code, and Descrioption
 * </summary> 
 * 
 * @constructor Coures
 * @param {string} code
 * @param {string} description
 * 
 
 */

        public Course(string code, string description)

        {
            this.Code = code;
            this.Description = description;

        }





    }
}
