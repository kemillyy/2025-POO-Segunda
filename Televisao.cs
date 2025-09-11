public class Televisao
{
    private const int VOL_MIN = 0;
    private const int VOL_MAX = 100;     
    private const int CANAL_MIN = 1;     
    private const int CANAL_MAX = 520;   

    private int _volume;           
    private int _canal;            
    private int _ultimoCanal = CANAL_MIN; 
    private bool _mudo;            

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;     
        _volume = 10;           
        _canal = CANAL_MIN;     
    }

    public float Tamanho { get; }        
    public int Resolucao { get; set; }   
    public bool Estado { get; private set; } 
    public int Volume => _mudo ? 0 : _volume;
    public int Canal => _canal;          
    public bool Mudo => _mudo;          

    public void Ligar()
    {
        Estado = true;              
        _canal = _ultimoCanal;     
    }

    public void Desligar()
    {
        Estado = false;             
        _ultimoCanal = _canal;      
    }

    public void AumentarVolume()
    {
        if (!Estado) return;        
        if (_mudo) _mudo = false;  

        if (_volume < VOL_MAX)      
            _volume++;
        else
            Console.WriteLine("Volume já está no máximo.");
    }

    public void DiminuirVolume()
    {
        if (!Estado) return;        
        if (_mudo) _mudo = false;  

        if (_volume > VOL_MIN)      
            _volume--;
        else
            Console.WriteLine("Volume já está no mínimo.");
    }

    public void AtivarOuDesativarMudo()
    {
        if (!Estado) return;        
        _mudo = !_mudo;            
    }

    public void ProximoCanal()
    {
        if (!Estado) return;       
        if (_canal < CANAL_MAX)    
            _canal++;
        else
            _canal = CANAL_MIN;    
    }

    public void CanalAnterior()
    {
        if (!Estado) return;        
        if (_canal > CANAL_MIN)    
            _canal--;
        else
            _canal = CANAL_MAX;     
    }

    public void IrParaCanal(int canal)
    {
        if (!Estado) return;        
        if (canal >= CANAL_MIN && canal <= CANAL_MAX)
            _canal = canal;         
        else
            Console.WriteLine($"Canal inválido! Digite entre {CANAL_MIN} e {CANAL_MAX}.");
    }

    public override string ToString()
    {
        return Estado
            ? $"TV ligada | Canal: {Canal} | Volume: {Volume} {(Mudo ? "(Mudo)" : "")}"
            : "TV desligada";
    }
}