using Avalonia.Interactivity;
using Avalonia.Controls;
using System;
using Avalonia.Input;

namespace Bin2Dec.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void OnConvertClick(object sender, RoutedEventArgs e)
    {
        // 1. Corrigido: Usando 'input' (minúsculo) para consistência
        string input = TxtBinary.Text ?? "";
        double decimalValue = 0;

        // 2. Validação de caracteres
        foreach(char c in input)
        {
            if (c != '0' && c != '1')
            {
                LblResult.Text = "Erro: Use apenas 0 e 1!"; // Adicionado ';'
                LblResult.Foreground = Avalonia.Media.Brushes.Red;
                return;
            }
            else
            {
                LblResult.Foreground = Avalonia.Media.Brushes.Green;
                LblResult.Text = $"ResultadoDecimal: {decimalValue}";
            }

            

        }

        // 3. Lógica matemática (Math.Pow)
        for (int i = 0; i < input.Length; i++)
        {
            // Pega o dígito da direita para a esquerda
            char digit = input[input.Length - 1 - i];
            
            if (digit == '1')
            {
                // Conforme o desafio: uma única função matemática
                decimalValue += Math.Pow(2, i);        
            }
        }

        // 4. Exibição do Resultado
        LblResult.Text = $"Resultado Decimal: {decimalValue}";
    }
}