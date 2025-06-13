using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodul9_2311104067.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Berlian Seva Astryana", Nim = "2311104067" },
            new Mahasiswa { Nama = "Dimastian Aji Wibowo", Nim = "2311104058" },
            new Mahasiswa { Nama = "Fahmi Hasan Asagaf", Nim = "2311104074" }
        };

        // GET /api/mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return daftarMahasiswa;
        }

        // GET /api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Add(Mahasiswa mhs)
        {
            daftarMahasiswa.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound();

            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}
