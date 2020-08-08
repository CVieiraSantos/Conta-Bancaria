using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Conta_Bancaria {
    class ContaBancaria {
        public int NumeroDaConta { get; private set; }
        public string TitularDaConta { get; set; }
        public double DepositoInicial { get; set; }
        public double Saldo { get; private set; }

        public double Imposto { get; private set; }

        public ContaBancaria() {

        }

        public ContaBancaria(int numeroDaConta, string titular, double depositoInicial, double saldo, double imposto) {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titular;
            DepositoInicial = depositoInicial;
            Saldo = saldo;
            Imposto = imposto;
        }

          
       
        
        public void Deposito(double deposito) {
            Saldo +=  deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque;

        }
         
        
        public void Taxa(double taxa) {
            Saldo -= Imposto;                                               
        }


        public override string ToString() {
            return "Conta " 
                + NumeroDaConta + ", " 
                + "Titular: " 
                + TitularDaConta + ", " + "Saldo: " + "$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
