using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        ApplicationDbContext db;
        public UsersController(ApplicationDbContext context)
        {
            db = context;
            if (!db.Users.Any())
            {
                db.Users.Add(new Models.User
                {
                    Id = 1,
                    LastName = "Андреева",
                    FirstName = "Елизавета",
                    MiddleName = "Артёмовна",
                    Address = "пр. Менделеева д16",
                    BirthDate = new DateTime(2004 / 12 / 02),
                    CompanyId = 1,
                    EmailList = "lizun0212@gmail.com",
                    Phone = "+7(477)734-78-89",
                    Sex = Models.Sex.Женский,
                    DepartamentId = 1,
                    PositionId=1,
                });
                db.Users.Add(new Models.User
                {
                    Id = 2,
                    LastName = "Панфилов",
                    FirstName = "Алексей",
                    MiddleName = "Алексеевич",
                    Address = "ул. Камышенская д107",
                    BirthDate = new DateTime(2004 / 06 / 15),
                    CompanyId = 3,
                    EmailList = "Panfilov@mail.ru",
                    Phone = "+7(456)939-36-96",
                    Sex = Models.Sex.Мужской,
                    DepartamentId = 1,
                    PositionId = 1,
                });
            }

            if (!db.Companies.Any())
            {
                db.Companies.Add(new Models.TCompany
                {
                    Id = 1,
                    Name = "Патронный завод",
                    Address = "ул. Краснопролетарская",
                    Phone = "+7(955)890-90-98",
                });
                db.Companies.Add(new Models.TCompany
                {
                    Id = 2,
                    Name = "Авиастар",
                    Address = "пер. Ульяновский",
                    Phone = "+7(898)880-87-37",
                });
                db.Companies.Add(new Models.TCompany
                {
                    Id = 3,
                    Name = "МедиаСофт",
                    Address = "ул. ЦУМ",
                    Phone = "+7(647)874-66-57",
                });
            }

            if (!db.Departaments.Any())
            {
                db.Departaments.Add(new Models.TDepartament
                {
                    Id = 1,
                    Name = "Информационный отдел",
                });
                db.Departaments.Add(new Models.TDepartament
                {
                    Id = 2,
                    Name = "Бухгалтерия",
                });
                db.Departaments.Add(new Models.TDepartament
                {
                    Id = 1,
                    Name = "Отдел кадров",
                });
                db.Departaments.Add(new Models.TDepartament
                {
                    Id = 1,
                    Name = "Цех по обработке металла",
                });
            }

            if (!db.Positions.Any())
            {
                db.Positions.Add(new Models.TPosition
                {
                    Id = 1,
                    Position = "Программист"
                });
                db.Positions.Add(new Models.TPosition
                {
                    Id = 2,
                    Position = "Системный администратор"
                });
                db.Positions.Add(new Models.TPosition
                {
                    Id = 3,
                    Position = "Бухгалетр"
                });
                db.Positions.Add(new Models.TPosition
                {
                    Id = 4,
                    Position = "Технолог"
                });
                db.Positions.Add(new Models.TPosition
                {
                    Id = 5,
                    Position = "Работник отдела кадров"
                });
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await db.Users.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TCompany>>> GetCompany()
        {
            return await db.Companies.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TDepartament>>> GetDepartament()
        {
            return await db.Departaments.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TPosition>>> GetPosition()
        {
            return await db.Positions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            User user = await db.Users.SingleOrDefaultAsync(x => x.Id == id);
            if(user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TCompany>> GetCompany(int id)
        {
            TCompany company = await db.Companies.SingleOrDefaultAsync(x => x.Id == id);
            if (company == null)
                return NotFound();
            return new ObjectResult(company);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TDepartament>> GetDepartament(int id)
        {
            TDepartament departament = await db.Departaments.SingleOrDefaultAsync(x => x.Id == id);
            if (departament == null)
                return NotFound();
            return new ObjectResult(departament);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TPosition>> GetPosition(int id)
        {
            TPosition position = await db.Positions.SingleOrDefaultAsync(x => x.Id == id);
            if (position == null)
                return NotFound();
            return new ObjectResult(position);
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            if(user == null)
            {
                return BadRequest();
            }

            db.Users.Add(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<TCompany>> PostCompany(TCompany company)
        {
            if (company == null)
            {
                return BadRequest();
            }

            db.Companies.Add(company);
            await db.SaveChangesAsync();
            return Ok(company);
        }

        [HttpPost]
        public async Task<ActionResult<TDepartament>> PostDepartament(TDepartament departament)
        {
            if (departament == null)
            {
                return BadRequest();
            }

            db.Departaments.Add(departament);
            await db.SaveChangesAsync();
            return Ok(departament);
        }

        [HttpPost]
        public async Task<ActionResult<TPosition>> PostPosition(TPosition position)
        {
            if (position == null)
            {
                return BadRequest();
            }

            db.Positions.Add(position);
            await db.SaveChangesAsync();
            return Ok(position);
        }

        [HttpPut]
        public async Task<ActionResult<User>> PutUser (User user)
        {
            if(user == null)
            {
                return BadRequest();
            }
            if(!db.Users.Any(x=>x.Id == user.Id))
            {
                return NotFound();
            }

            db.Update(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPut]
        public async Task<ActionResult<TCompany>> PutCompany(TCompany company)
        {
            if (company == null)
            {
                return BadRequest();
            }
            if (!db.Companies.Any(x => x.Id == company.Id))
            {
                return NotFound();
            }

            db.Update(company);
            await db.SaveChangesAsync();
            return Ok(company);
        }

        [HttpPut]
        public async Task<ActionResult<TDepartament>> PutDepartament(TDepartament departament)
        {
            if (departament == null)
            {
                return BadRequest();
            }
            if (!db.Departaments.Any(x => x.Id == departament.Id))
            {
                return NotFound();
            }

            db.Update(departament);
            await db.SaveChangesAsync();
            return Ok(departament);
        }

        [HttpPut]
        public async Task<ActionResult<TPosition>> PutPosition(TPosition position)
        {
            if (position == null)
            {
                return BadRequest();
            }
            if (!db.Positions.Any(x => x.Id == position.Id))
            {
                return NotFound();
            }

            db.Update(position);
            await db.SaveChangesAsync();
            return Ok(position);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            User user = db.Users.FirstOrDefault(x => x.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            db.Users.Remove(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TCompany>> DeleteCompany(int id)
        {
            TCompany company = db.Companies.FirstOrDefault(x => x.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            db.Companies.Remove(company);
            await db.SaveChangesAsync();
            return Ok(company);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TDepartament>> DeleteDepartament(int id)
        {
            TDepartament departament = db.Departaments.FirstOrDefault(x => x.Id == id);
            if (departament == null)
            {
                return NotFound();
            }
            db.Departaments.Remove(departament);
            await db.SaveChangesAsync();
            return Ok(departament);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TPosition>> DeletePosition(int id)
        {
            TPosition position = db. Positions.FirstOrDefault(x => x.Id == id);
            if (position == null)
            {
                return NotFound();
            }
            db.Positions.Remove(position);
            await db.SaveChangesAsync();
            return Ok(position);
        }

    }
}
