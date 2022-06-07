using UnityEngine;


namespace Code.Extensions{
    public static class ResourceLoader
    {
        public static T LoadModel<T>() where T : Object
        {
            Debug.Log($"Start loading:Models/{typeof(T).Name}");
            var result = Resources.Load<T>($"Models/{typeof(T).Name}");
            if (result == null)
            {
                Debug.LogError($"Error loading model: {typeof(T)}");
                return null;
            }
            Debug.Log($"{StringManager.RESULT_OF_LOADING_DATA_MODEL} - {nameof(result)}:{result}");
            return result;
        }

        public static T LoadConfig<T>() where T : Object
        {
            Debug.Log($"Start loading:Configs/{typeof(T).Name}");
            var result = Resources.Load<T>($"Configs/{typeof(T).Name}");
            if (result == null)
            {
                Debug.LogError($"Error loading config: {typeof(T)}");
                return null;
            }
            Debug.Log($"{StringManager.RESULF_OF_LOADING_RESOURCES} - {nameof(result)}:{result}");
            return result;
        }
    }
}