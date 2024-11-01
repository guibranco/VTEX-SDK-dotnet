from flask import Flask
from .attachment_api import attachment_api

app = Flask(__name__)
app.register_blueprint(attachment_api)

if __name__ == '__main__':
    app.run(debug=True)
