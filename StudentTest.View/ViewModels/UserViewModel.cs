using StudentTest.Domain.Entities.QuizEntities;
using StudentTest.Domain.Interfaces.Repository;
using StudentTest.Domain.Interfaces.Services;
using StudentTest.View.Commands;
using StudentTest.View.Status.Accounts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StudentTest.View.ViewModels
{
	public class UserViewModel : ViewModelBase
	{


		IEnumerable<Category> _GetCollection;
		public IEnumerable<Category> GetCollection
		{
			get => _GetCollection;
			set
			{
				_GetCollection = value;
				OnPropertyChanged("GetCollection");
			}
		}


		List<CategoryQuiz> _GetCollection2;
		public List<CategoryQuiz> GetCollection2
		{
			get => _GetCollection2;
			set
			{
				_GetCollection2 = value;
				OnPropertyChanged("GetCollection2");
			}
		}

		private Category _category;
		public Category Category
		{
			get => _category;
			set
			{
				_category = value;
				OnPropertyChanged(nameof(Category));
			}
		}

		private CategoryQuiz _category2;
		public CategoryQuiz Category2
		{
			get => _category2;
			set
			{
				_category2 = value;
				OnPropertyChanged(nameof(Category2));
			}
		}

		private UserResult _userResult;
		public UserResult UserResult
		{
			get => _userResult;
			set
			{
				_userResult = value;
				OnPropertyChanged(nameof(UserResult));
			}
		}

		private string _question;
		public string Question
		{
			get => _question;
			set
			{
				_question = _category2.Quiz.Question;
				OnPropertyChanged("Question");
			}
		}

		private string _answerA;
		public string AnswerA
		{
			get => _answerA;
			set
			{
				_answerA = _category2.Quiz.AnswerA;
				OnPropertyChanged(nameof(AnswerA));
			}
		}

		private string _answerB;
		public string AnswerB
		{
			get => _answerB;
			set
			{
				_answerB = _category2.Quiz.AnswerB;
				OnPropertyChanged(nameof(AnswerB));
			}
		}

		private string _answerC;
		public string AnswerC
		{
			get => _answerC;
			set
			{
				_answerC = _category2.Quiz.AnswerC;
				OnPropertyChanged(nameof(AnswerC));
			}
		}

		private string _answerD;
		public string AnswerD
		{
			get => _answerD;
			set
			{
				_answerD = _category2.Quiz.AnswerD;
				OnPropertyChanged(nameof(AnswerD));
			}
		}

		private int _countRightAnswer;
		public int CountRightAnswer
		{
			get => _countRightAnswer;
			set
			{
				_countRightAnswer = value;
				OnPropertyChanged("CountRightAnswer");
			}
		}

		private string _finalResult;
		public string FinalResul
		{
			get => _finalResult;
			set
			{
				_finalResult = _userResult.CountOfCorrectAnswer.ToString();
				OnPropertyChanged(nameof(FinalResul));
			}
		}

		public MessageViewModel ErrorMessageViewModel { get; }

		public string ErrorMessage
		{
			set => ErrorMessageViewModel.Message = value;
		}

		public ICommand CategoryGetCommand { get; }
		public ICommand StartTestCommand { get; }
		public ICommand ACommand { get; }
		public ICommand BCommand { get; }
		public ICommand CCommand { get; }
		public ICommand DCommand { get; }
		public ICommand DisplayUserResultCommand { get; }

		public UserViewModel(ICategoryService categoryService, IGetQuizService getQuizService, ICountQuestionsService countQuestionsService,
			IUserResultCreationService userResultCreationService, IAccountStore accountStore)
		{
			ErrorMessageViewModel = new MessageViewModel();

			ACommand = new ACommand(this);

			BCommand = new BCommand(this);

			CCommand = new CCommand(this);

			DCommand = new DCommand(this);

			StartTestCommand = new DisplayQuizCommand(this, getQuizService, countQuestionsService);

			CategoryGetCommand = new GetCategoryListCommand(this, categoryService);

			DisplayUserResultCommand = new DisplayUserResultCommand(this, userResultCreationService, accountStore, countQuestionsService);
		}
	}
}
