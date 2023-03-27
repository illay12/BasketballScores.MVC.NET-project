using BasketballScores.Data;
using BasketballScores.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

namespace BasketballScores.Controllers;

public class ScoreBoardController : Controller
{
    private readonly ApplicationDbContext _db;

    public ScoreBoardController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        IEnumerable<ScoreBoard> objScoreBoardList = _db.ScoreBoards;
        return View(objScoreBoardList);
    }
    
    //GET
    public IActionResult Create()
    {
        return View();
    }

    //POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(ScoreBoard obj)
    {
        if (ModelState.IsValid)
        {
            _db.ScoreBoards.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }

}
