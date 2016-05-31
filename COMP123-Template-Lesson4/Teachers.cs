using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Template_Lesson4
{
    /**
     * <summary>
     * Teacher class is derived from the person class
     * </summary>
     *
     *@class Teacher
     *@extends Person 
     * 
      */
    class Teachers:Person
    {
        //PRIVATE INSTANCE VARIABLE++++++++++++++++++++++++++++++++++++++++++++++++
        private string _employeeID;


        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public string EmployeeID
        {

            get
            {

                return this._employeeID;
            }

            set
            {
                this._employeeID = value;

            }
        }

        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is an empty constructor for the Teacherwith three paarameters
         * 
         * </summary>
         * @constructor Teacher
         * @extends Person
         * @param {string} name
         * @param {int} age
         * @param {string} studentID
         * */
        public Teachers( string name, int age, string emplyeeID)
            :base(name,age)

        {
            this.EmployeeID = emplyeeID;
        }


        public void Teacher()

        {
            Console.WriteLine(this.Name + " teachers");

        }

        }

    
}
