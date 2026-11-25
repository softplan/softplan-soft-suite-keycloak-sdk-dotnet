
#nullable enable

namespace Softplan.Soft.Suite.Keycloak.Sdk
{
    public partial interface IKeycloakClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}