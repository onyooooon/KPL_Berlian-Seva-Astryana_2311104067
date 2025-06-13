using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    private const string filePath = "covid_config.json";

    public static CovidConfig LoadConfig()
    {
        if (!File.Exists(filePath))
        {
            var defaultConfig = new CovidConfig
            {
                satuan_suhu = "celcius",
                batas_hari_deman = 14,
                pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini",
                pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini"
            };
            File.WriteAllText(filePath, JsonSerializer.Serialize(defaultConfig));
            return defaultConfig;
        }
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<CovidConfig>(json);
    }

    public void SaveConfig()
    {
        File.WriteAllText(filePath, JsonSerializer.Serialize(this));
    }

    public void UbahSatuan()
    {
        satuan_suhu = (satuan_suhu == "celcius") ? "fahrenheit" : "celcius";
        SaveConfig();
    }
}
