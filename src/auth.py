from functools import wraps
from flask import request, jsonify

def requires_auth(f):
    @wraps(f)
    def decorated(*args, **kwargs):
        auth = request.headers.get('Authorization', None)
        if not auth:
            return jsonify({'message': 'Authorization header is expected'}), 401

        # Here you would add your logic to verify the token
        return f(*args, **kwargs)

    return decorated
