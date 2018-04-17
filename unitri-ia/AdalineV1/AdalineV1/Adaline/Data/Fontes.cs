﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdalineV1.Network
{
    static class Fontes
    {

        static Double[] a1 = { -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, 1, 1, 1, -1, 1, 1, 1 };
        static Double[] b1 = { 1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, -1 };
        static Double[] c1 = { -1, -1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, -1, -1, 1, 1, 1, 1, -1 };
        static Double[] d1 = { 1, 1, 1, 1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, 1, 1, 1, 1, 1, -1, -1 };
        static Double[] e1 = { 1, 1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1 };
        static Double[] j1 = { -1, -1, -1, 1, 1, 1, 1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1 };
        static Double[] k1 = { 1, 1, 1, -1, -1, 1, 1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, 1, 1 };

        static Double[] a2 = { -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1 };
        static Double[] b2 = { 1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, -1 };
        static Double[] c2 = { -1, -1, 1, 1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1 };
        static Double[] d2 = { 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, 1, -1, 1, 1, 1, 1, 1, -1, -1 };
        static Double[] e2 = { 1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1 };
        static Double[] j2 = { -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1 };
        static Double[] k2 = { 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1 };

        static Double[] a3 = { -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, 1, 1 };
        static Double[] b3 = { 1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, 1, 1, 1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, -1 };
        static Double[] c3 = { -1, -1, 1, 1, 1, -1, 1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1 };
        static Double[] d3 = { 1, 1, 1, 1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, 1, -1, 1, 1, 1, 1, 1, -1, -1 };
        static Double[] e3 = { 1, 1, 1, 1, 1, 1, 1, -1, 1, -1, -1, -1, -1, 1, -1, 1, -1, -1, 1, -1, -1, -1, 1, 1, 1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, 1 };
        static Double[] j3 = { -1, -1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, -1, -1 };
        static Double[] k3 = { 1, 1, 1, -1, -1, 1, 1, -1, 1, -1, -1, -1, 1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, 1, -1, -1, -1, -1, -1, 1, -1, 1, -1, -1, -1, -1, 1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, 1, 1, 1, -1, -1, 1, 1 };

        static Double[] saidasA =
        {
            1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0,
            1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0,
            1.0, -1.0, -1.0, -1.0, -1.0, -1.0, -1.0
        };

        static Double[] saidasB =
        {
               -1.0, 1.0, -1.0, -1.0, -1.0, -1.0, -1.0,
               -1.0, 1.0, -1.0, -1.0, -1.0, -1.0, -1.0,
               -1.0, 1.0, -1.0, -1.0, -1.0, -1.0, -1.0
        };

        static Double[] saidasC =
        {
                -1.0, -1.0, 1.0, -1.0, -1.0, -1.0, -1.0,
                -1.0, -1.0, 1.0, -1.0, -1.0, -1.0, -1.0,
                -1.0, -1.0, 1.0, -1.0, -1.0, -1.0, -1.0
        };

        static Double[] saidasD =
        {
                -1.0, -1.0, -1.0, 1.0, -1.0, -1.0, -1.0,
                -1.0, -1.0, -1.0, 1.0, -1.0, -1.0, -1.0,
                -1.0, -1.0, -1.0, 1.0, -1.0, -1.0, -1.0
        };

        static Double[] saidasE =
        {
            -1.0, -1.0, -1.0, -1.0, 1.0, -1.0, -1.0,
            -1.0, -1.0, -1.0, -1.0, 1.0, -1.0, -1.0,
            -1.0, -1.0, -1.0, -1.0, 1.0, -1.0, -1.0
        };

        static Double[] saidasJ =
        {
                -1.0, -1.0, -1.0, -1.0, -1.0, 1.0, -1.0,
                -1.0, -1.0, -1.0, -1.0, -1.0, 1.0, -1.0,
                -1.0, -1.0, -1.0, -1.0, -1.0, 1.0, -1.0
        };

        static Double[] saidasK =
        {
                -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, 1.0,
                -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, 1.0,
                -1.0, -1.0, -1.0, -1.0, -1.0, -1.0, 1.0
        };

        public static double[] A1 { get => a1; }
        public static double[] B1 { get => b1; }
        public static double[] C1 { get => c1; }
        public static double[] D1 { get => d1; }
        public static double[] E1 { get => e1; }
        public static double[] J1 { get => j1; }
        public static double[] K1 { get => k1; }

        public static double[] A2 { get => a2; }
        public static double[] B2 { get => b2; }
        public static double[] C2 { get => c2; }
        public static double[] D2 { get => d2; }
        public static double[] E2 { get => e2; }
        public static double[] J2 { get => j2; }
        public static double[] K2 { get => k2; }

        public static double[] A3 { get => a3; }
        public static double[] B3 { get => b3; }
        public static double[] C3 { get => c3; }
        public static double[] D3 { get => d3; }
        public static double[] E3 { get => e3; }
        public static double[] J3 { get => j3; }
        public static double[] K3 { get => k3; }

        public static double[] SaidasA { get => saidasA; }
        public static double[] SaidasB { get => saidasB; }
        public static double[] SaidasC { get => saidasC; }
        public static double[] SaidasD { get => saidasD; }
        public static double[] SaidasE { get => saidasE; }
        public static double[] SaidasJ { get => saidasJ; }
        public static double[] SaidasK { get => saidasK; }

        public static List<Double[]> obterVetoresTreinamento()
        {
            return new List<Double[]> { A1, B1, C1, D1, E1, J1, K1, A2, B2, C2, D2, E2, J2, K2, A3, B3, C3, D3, E3, J3, K3 };
        }

        public static List<Double[]> obterSaidas()
        {
            return new List<double[]> { SaidasA, SaidasB, SaidasC, SaidasD, saidasE, SaidasJ, SaidasK };
        }

    }
}
