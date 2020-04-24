using FitnessCenter.BLL.Interface;
using FitnessCenter.DAL;
using FitnessCenter.DAL.Interface;

namespace FitnessCenter.Common
{
    public static class DependenciesResolver
    {
        private static IClientDao _clientDao { get; set; } = new ClientDao();

        public static IClientLogic ClientLogic { get; set; } = new ClientLogic(_clientDao);

        private static ICoachDao _coachDao { get; set; } = new CoachDao();

        public static ICoachLogic CoachLogic { get; set; } = new CoachLogic(_coachDao);

        private static IHallDao _hallLogic { get; set; } = new HallDao();

        public static IHallLogic HallLogic { get; set; } = new HallLogic(_hallLogic);

        private static ILessonsDao _lessonsLogic { get; set; } = new LessonsDao();

        public static ILessonsLogic LessonsLogic { get; set; } = new LessonsLogic(_lessonsLogic);

    }

}
