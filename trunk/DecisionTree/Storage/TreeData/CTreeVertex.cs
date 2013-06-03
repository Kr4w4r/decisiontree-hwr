﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionTree.Storage.TreeData
{
    /// <summary>
    /// Klasse zum Speichern eines Knoten im Baum
    /// </summary>
    public class CTreeVertex
    {
        protected CTreeVertex mParentVertex = null;
        protected List<CTreeVertex> mChildNodes = new List<CTreeVertex>();
        protected CTreeEdge mParentEdge = null;
        protected CTreeGraph mGraph;

        protected CAttributeType mAttributeType;

        protected string mName = "keine Regel festgelegt";

        #region Testdaten für Präsi -> Danach wieder löschen
        /*protected int mNumObjects;
        protected int mNumObjectsYes;
        protected int mNumObjectsNo;
        protected double mEntropy;
        
        public void setDemoData(string vertexName, int countObjects, int countObjectsYes, int countObjectsNo, double entropy)
        {
            if (vertexName != "")
            {
                mAttributeType = new CAttributeType(0);
                mAttributeType.Name = vertexName;
            }

            mNumObjects = countObjects;
            mNumObjectsYes = countObjectsYes;
            mNumObjectsNo = countObjectsNo;
            mEntropy = entropy;
        }*/
        #endregion

        /*********************************************************************/
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="parent">Übergeordneter Knoten im Baum</param>
        /// <param name="attributeType">Attributtyp nach dem aufgeteilt werden soll</param>
        public CTreeVertex(CTreeVertex parent, CTreeGraph graph, CAttributeType attributeType = null)
        { 
            mParentVertex = parent;
            mGraph = graph;
            AttributeType = attributeType;
        }

        /*********************************************************************/
        /// <summary>
        /// Attributtyp welcher durch diesen Knoten repräsentiert wird.
        /// </summary>
        public CAttributeType AttributeType
        {
            get { return mAttributeType; }
            set 
            { 
                mAttributeType = value;

                if (mAttributeType != null)
                {
                    mName = mAttributeType.Name;
                }
                else
                {
                    mName = "keine Regel festgelegt";
                }
            }
        }

        /*********************************************************************/
        /// <summary>
        /// Übergeordneter Knoten dieses Knotens
        /// </summary>
        public CTreeVertex ParentVertex
        {
            get { return mParentVertex; }
        }

        public List<CTreeVertex> ChildList
        {
            get { return mChildNodes; }
        }


        /*********************************************************************/
        /// <summary>
        /// Verbindung zum übergeordnetten Knoten
        /// </summary>
        public CTreeEdge ParentEdge
        {
            get { return mParentEdge; }
            set { mParentEdge = value; }
        }

        public string VertexName
        {
            get { return mName = mAttributeType.Name; }
        }

        public int CountObjects
        {
            // TODO CTreeVertex::CountObjects
            get { return 0; }
        }

        /// <summary>
        /// Nochmal überdenken wie man das schöner machen kann
        /// </summary>
        public int[] CountObjectsPerClass
        {
            // // TODO CTreeVertex::CountObjectsPerClass
            get 
            {
                /*int [] ret = new int[2];
                ret[0] = mNumObjectsYes;
                ret[1] = mNumObjectsNo;
                return ret;*/
                return new int[1];
            }
        }

        public double Entropy
        {
            // // TODO CTreeVertex::Entropy
            get { return 0; }
        }

        

    }// class
} // namespace
