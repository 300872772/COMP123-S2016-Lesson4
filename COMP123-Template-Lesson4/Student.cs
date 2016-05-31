using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Template_Lesson4
{
    //Note: this is called drive class or sub class or child class. Superclass or base class

    /**
     * <summary>
     * This is the student class which is child of Person class
     * </summary>
     * */
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLE++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private string _studentID;

        // PUBLIC PROPERTY++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This property , StudentID
        * </summary>
        * */
        public string StudentID
        {
            get
            {

                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }

        }


        //CONSTRUCTORS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is an empty constructor for the student class
         * 
         * </summary>
         * @constructor Student
         * @extends Person
         * @param {string} name
         * @param {int} age
         * @param {string} studentID
         * */

        public Student(string name, int age, string studintID)
            : base(name, age)
        {
            this.StudentID = studintID;
        }


        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method enables the Studies behaviour for the student
         * 
         * @method Studies
         * @returns {void}
         * </summary>
         */

        public void Studies()
            {
            //encapsulating 
            Console.WriteLine(this.Name + " Studies");

            }

}
}
