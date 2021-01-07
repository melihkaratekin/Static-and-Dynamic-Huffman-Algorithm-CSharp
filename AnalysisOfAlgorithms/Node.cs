﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnalysisOfAlgorithms
{
    class Node
    {
        public char Symbol { get; set; }
        public char Symbol2 { get; set; }
        public int Frequency { get; set; }
        public string Codeword { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }

        public List<bool> Traverse(char symbol, List<bool> data)
        {
            // Leaf
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (Left != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = Left.Traverse(symbol, leftPath);
                }

                if (Right != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = Right.Traverse(symbol, rightPath);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }


        public List<int> TraverseInt(char symbol, List<int> data)
        {
            // Leaf
            if (Right == null && Left == null)
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<int> left = null;
                List<int> right = null;

                if (Left != null)
                {
                    List<int> leftPath = new List<int>();
                    leftPath.AddRange(data);
                    leftPath.Add(0);

                    left = Left.TraverseInt(symbol, leftPath);
                }

                if (Right != null)
                {
                    List<int> rightPath = new List<int>();
                    rightPath.AddRange(data);
                    rightPath.Add(1);
                    right = Right.TraverseInt(symbol, rightPath);
                }

                if (left != null)
                {
                    return left;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
