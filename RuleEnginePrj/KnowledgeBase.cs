using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class KnowledgeBase
    {
        private Rule[] agenda;
        private Rule[] ruleLib;
        private Fact[] facts;
        private String targetVariable;

        private void init()
        {
            //init rules

            //init facts
        }

        public void setTargetVar(string target)
        {
            this.targetVariable = target;
        }

        public void evalTarget()
        {
            //fire & assert facts from rules where possible - forward chaining
            //dismiss fired rules

            //is target in facts

            //while target not found
                //find rule with least unknown conditions
                // try to eval condition variables of selected rule - could be recursive
                //if not enough - ask user about fact
                    //do
                        //assert fact 
                        // do forward chaining
                    //while asserting new facts 
                
        }


    }
}
