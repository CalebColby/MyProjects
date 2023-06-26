using AuditionAPI.Models;

namespace AuditionAPI.DataAccessLayer
{
    public interface iDAL
    {
        public void createPreformance(Preformance newPreformance);
        public void updatePreformanceByID(Guid updateID, Preformance updatePreformance);
        public void deletePreformance(Guid deleteID);
        public Preformance getPreformanceByID(Guid searchID);
        public Preformance GetPreformanceByName(string searchName);
        public List<Preformance> getAllPreformances();


        public void createProfessional(Professional newProfessional);
        public void updateProfessionalByID(Guid updateID, Professional updateProfessional);
        public void deleteProfessional(Guid deleteID);
        public Professional getProfessionalByID(Guid searchID);
        public Professional GetProfessionalByName(string searchName);
        public List<Professional> getAllProfessionals();
    }
}
