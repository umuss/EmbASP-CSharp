﻿using it.unical.mat.embasp.languages;
using System;
using System.Collections.Generic;
using System.Text;

namespace it.unical.mat.test
{
    [Id("edge")]
    class Edge
    {
        [Param(0)]
        private int from;

        [Param(1)]
        private int to;

        [Param(2)]
        private int weight;

        public Edge()
        {
            this.from = 0;
            this.to = 0;
            this.weight = 0;
        }

        public Edge(int from, int to, int weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }

        public int getFrom()
        {
            return from;
        }

        public void setFrom(int from)
        {
            this.from = from;
        }

        public int getTo()
        {
            return to;
        }

        public void setTo(int to)
        {
            this.to = to;
        }

        public int getWeight()
        {
            return weight;
        }

        public void setWeight(int weight)
        {
            this.weight = weight;
        }
    }
}