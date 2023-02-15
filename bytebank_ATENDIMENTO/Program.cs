using bytebank_ATENDIMENTO.bytebank.Atendimento;
using GeradorChavePix;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();

List<string> listaChaves = GeradorChavePix.GeradorPix.GetChavesPix(15); 
foreach(string chave in listaChaves)
{
    Console.WriteLine(chave);
}